#!/bin/bash

# Directory containing the images
input_dir="./"  # Adjust this if your images are in another directory

# Loop through all PNG files
for img in "$input_dir"*.png; do
    if [ -f "$img" ]; then
        # Strip metadata and overwrite the file
        mogrify -strip "$img"
        echo "Stripped metadata from $img"
    fi
done
