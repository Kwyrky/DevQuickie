#!/bin/bash

# Directory containing the images
input_dir="./"  # Adjust this if your images are in another directory
output_size="100x100"  # Set the target size

# Loop through all PNG files
for img in "$input_dir"pt*.png; do
    if [ -f "$img" ]; then
        # Extract the filename without extension
        filename=$(basename "$img")
        # Convert to 100x100, maintaining aspect ratio and padding to make square
        convert "$img" -resize "$output_size^" -gravity center -extent "$output_size" "$img"
        echo "Resized $img to $output_size"
    fi
done

