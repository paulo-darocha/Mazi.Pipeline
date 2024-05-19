using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Azure.Storage;
using Microsoft.Extensions.Options;
using System;

namespace Mazi.Pipeline.Api.AzureStorage;

public class AzureBlobImageStorageHelper : IAzureBlobImageSasTokenGenerator
{
   private readonly AzureBlobImageStorageOptions _options;

   public AzureBlobImageStorageHelper(
      IOptionsMonitor<AzureBlobImageStorageOptions> options
   )
   {
      if (options is null)
      {
         throw new ArgumentNullException(nameof(options));
      }

      _options = options.CurrentValue;
   }

   public Uri GetBlobUriWithSasToken(string containerName, string blobName)
   {
      throw new NotImplementedException();
   }

   public Uri GetBlobUri(string containerName, string blobName)
   {
      throw new NotImplementedException();
   }

   private BlobServiceClient _blobServiceClientInstance;
   private BlobServiceClient BlobServiceClientInstance
   {
      get { throw new NotImplementedException(); }
   }

   private StorageSharedKeyCredential GetAzureCredentials()
   {
      throw new NotImplementedException();
   }
}
