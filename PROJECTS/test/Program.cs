using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Threading.Tasks;

public class Program
{
    private const string blobServiceEndpoint = "https://mediastronguyen.blob.core.windows.net/";
    private const string storageAccountName = "medaistornguyen";
    private const string storageAccountKey = "zEYoVMftkz7eGRRmA3t+VDDdassad7yi892acsASD41Wf";

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello BlobStorage");
        StorageSharedKeyCredential accountCredentials = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

        BlobServiceClient service = new BlobServiceClient(new Uri(blobServiceEndpoint), accountCredentials);

        AccountInfo info = await serviceClient.GetAccountInfoAsync();

        await Console.Out.WriteLineAsync($"Connected to Azure Storage Account");
        await Console.Out.WriteLineAsync($"Account name: \t{storageAccountName}");
        await Console.Out.WriteLineAsync($"Account kind: \t{info?.AccountKind}");
        await Console.Out.WriteLineAsync($"Account sku: \t{info?.SkuName}");
    }
}