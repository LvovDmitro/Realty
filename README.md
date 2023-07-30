# x-ray classification

Learning of chest radiographs in the application of pulmonary edema assessment.

# Instructions

The main file is test_model.ipynb. This file contain preprocessed datasets, the model, and gui. The cl_model, fc_model - models with different architectures, just some useful files, they are not directly related to the model. The prep.py file contain a CustomDatases class that helps to make dataset with chest radiographs. In logs directory you can find test metrics of loss, auroc, f1-score and accuracy.

## Usage

You need to import test_model.ipynb and prep.py. With IDE, download all libs, you find their in first code blocks. To load trained model, save the m4.pt file from [disk](https://drive.google.com/file/d/1C-Hji7nU2CQO_HEYD_ePInjfkixWukT9/view?usp=sharing) in directory with this files. If app don't see m4 file, just write full path to this file.

# Data

## MIMIC-CHR-JPG

All data was took from [MIMIC-CXR](https://physionet.org/content/mimic-cxr/2.0.0/). It's large publicly available dataset of chest radiographs in DICOM format with free-text radiology reports. The dataset contains 377,110 images corresponding to 227,835 radiographic studies performed at the Beth Israel Deaconess Medical Center in Boston, MA. JPG files files was converted from this dataset.

## Pulmonary edema severity

We aim to classify a given chest x-ray image into one of the four ordinal levels: no edema (0), vascular congestion (1), interstitial edema (2), and alveolar edema (3).

# GUI

You can load any image on the BROWSE button. After that, model give you predcition 1 of 4 classes. You can transform image with filters in transformation tab.

# Contact

If you have problems with application, contact me in tg(@dimitriy_lvov)
