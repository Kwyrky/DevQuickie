#!/bin/bash

# Directory containing the images
input_dir="./"  # Adjust this if your images are in another directory

# Loop through all JPEG and JPG files
for img in "$input_dir"*.{jpeg,jpg}; do
    if [ -f "$img" ]; then
        # Extract the filename without extension
        filename=$(basename "$img" | sed 's/\(.*\)\..*/\1/')
        # Convert to PNG
        convert "$img" "$input_dir$filename.png"
        echo "Converted $img to $filename.png"
    fi
done

