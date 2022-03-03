using Azure.Storage.Blobs;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=myteststoragewithunique;AccountKey=vlZKLxCpl/SiIxAAnYDrFH/hukTXtZrlOenuLwWwdLYushR1xvmqXDXrGNsotHflRj67T3EVkEp3+AStUBT0OA==;EndpointSuffix=core.windows.net";
var containerString = "testcontainer";

var client = new BlobContainerClient(connectionString, containerString);
var blobs = client.GetBlobs();

foreach (var blob in blobs)
{
    Console.WriteLine(blob.Name); //prints hello.txt in my case
}