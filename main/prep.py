import os
import pandas as pd
from torch.utils.data import Dataset
import numpy as np
from skimage import io
from PIL import Image
from torchvision import transforms

class CustomImageDataset(Dataset):
    def __init__(self, annotations_file, img_dir, transform=None, target_transform=None):
        self.img_labels = pd.read_csv(annotations_file)
        self.img_dir = img_dir
        self.transform = transform
        self.target_transform = target_transform
        self.img_format = '.jpg'

    def __len__(self):
        return len(self.img_labels)

    def __getitem__(self, idx):
        img_path = os.path.join(self.img_dir, self.img_labels.iloc[idx, 2]+self.img_format)
        if self.target_transform:
            image = Image.open(img_path).convert("RGB")
            preprocess = transforms.Compose([
                transforms.Resize(256),
                transforms.CenterCrop(128),
                transforms.ToTensor(),
                transforms.Normalize([0.5], [0.5])
            ])
            image = preprocess(image)
            image = image.reshape(3, image.shape[1], image.shape[1])
        else:
            image = io.imread(img_path)
            image = image.astype(np.float32)
            image = image / np.max(image)
            if self.transform:
                image = self.transform(image)
            image = image.reshape(1, image.shape[0], image.shape[1])
        label = self.img_labels.iloc[idx, 3]
        sample = [image, label]
        return sample
