import numpy as np 
import pandas as pd 
import seaborn as sns
import matplotlib.pyplot as plt

import tensorflow as tf
from tensorflow import keras
from tensorflow.keras import layers
tf.random.set_seed(100)

from sklearn.model_selection import train_test_split
from sklearn.metrics import r2_score

# Stap 1: Data inladen
df = sns.load_dataset('mpg')
print("Shape:", df.shape)

# Stap 2: Data preprocessing
df['horsepower'] = df['horsepower'].fillna(df['horsepower'].median())
df = df.drop(['name'], axis=1)
df = pd.get_dummies(df, columns=['cylinders'], drop_first=True, prefix='Cylinder')
df = pd.get_dummies(df, columns=['model_year'], drop_first=True, prefix='Year')
df = pd.get_dummies(df, columns=['origin'], drop_first=True, prefix='Origin')

# Stap 3: Normaliseren van features
target_variable = ['mpg']
predictors = list(set(df.columns) - set(target_variable))
df[predictors] = df[predictors] / df[predictors].max()

# Stap 4: Data voorbereiden
X = df[predictors].astype(np.float32).values
y = df[target_variable].astype(np.float32).values

# Stap 5: Train-test split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.30, random_state=100)
print("Train shape:", X_train.shape)
print("Test shape:", X_test.shape)

# Stap 6: Model bouwen
model = tf.keras.Sequential([
    tf.keras.Input(shape=(X_train.shape[1],)),
    tf.keras.layers.Dense(32, activation='relu'),
    tf.keras.layers.Dense(16, activation='relu'),
    tf.keras.layers.Dense(8, activation='relu'),
    tf.keras.layers.Dense(4, activation='relu'),
    tf.keras.layers.Dense(1)
])

# Compileren
optimizer = tf.keras.optimizers.Adam(learning_rate=0.01)
model.compile(loss='mae', metrics=['mae'], optimizer=optimizer)

# Model trainen
model.fit(X_train, y_train, epochs=50, verbose=1)

# Stap 7: Evaluatie
print("Train evaluation:", model.evaluate(X_train, y_train))
print("Test evaluation:", model.evaluate(X_test, y_test))

# Stap 8: R2-score berekenen
pred_train = model.predict(X_train)
pred_test = model.predict(X_test)

r2_train = r2_score(y_train, pred_train)
r2_test = r2_score(y_test, pred_test)

print("R2 Score (train):", r2_train)
print("R2 Score (test):", r2_test)
