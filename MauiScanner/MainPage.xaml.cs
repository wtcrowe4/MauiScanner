﻿using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;

namespace MauiScanner;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.OneDimensional,
            AutoRotate = true,
            Multiple = true
        };
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        foreach (var barcode in e.Results)
            Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
    }


}

