import numpy as np 
import pandas as pd 
import seaborn as sns
import matplotlib.pyplot as plt

import tensorflow as tf
tf.random.set_seed(42)
from sklearn.model_selection import train_test_split
from sklearn.metrics import r2_score

df = sns.load_dataset('mpg')
print(df.shape)