# Simple Csharp QR Generator

This is a simple QR Code generator application using C#. It allows users to input text and generate a QR code, which can then be saved as an image file.

![C# QR Code Generator Demo](https://content.bytehide.com/wp-content/uploads/2023/05/Screenshot_1.png)

## Features

- Generate QR codes from user-provided text
- Save the generated QR code as an image file
- User-friendly interface with centered controls

## Dependencies

- [ZXing.Net](https://github.com/micjahn/ZXing.Net) for generating QR codes

## Usage

1. Open the project in your favorite C# development environment
2. Add the ZXing.Net library to your project
3. Build and run the application
4. Input your desired text and click the "Generate" button to generate a QR code
5. Click the "Save" button to save the QR code as an image file

## Code Explanation

The main class `Form1` is responsible for handling the UI and generating the QR codes. The UI elements are setup in the constructor, and the QR code generation is done using the `GenerateQRCode` method.

The `GenerateQRCode` method takes an input text, creates a `ZXing.BarcodeWriterPixelData` object with the specified QR code format and dimensions, and then generates a Bitmap representing the QR code.

The event handlers for the "Generate" and "Save" buttons are responsible for generating the QR code using the user-provided text and saving it as an image file.

## More Information

For more information on QR code generation in C#, check out this in-depth guide: [C# QR Code Generator](https://www.bytehide.com/blog/qr-generator-csharp)