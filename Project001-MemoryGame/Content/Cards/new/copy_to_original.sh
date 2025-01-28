#!/bin/bash

# Directory where PNG files are located
input_dir="./"  # Adjust this if your images are in another directory

# Subfolder to store original images
subfolder="original"

# Create the subfolder if it doesn't exist
mkdir -p "$input_dir$subfolder"

# Loop through all PNG files and copy them to the subfolder
for img in "$input_dir"*.png; do
    if [ -f "$img" ]; then
        cp "$img" "$input_dir$subfolder/"
        echo "Copied $img to $subfolder/"
    fi
done

