using Azure.Storage.Blobs;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=myteststoragewithunique;AccountKey=vlZKLxCpl/SiIxAAnYDrFH/hukTXtZrlOenuLwWwdLYushR1xvmqXDXrGNsotHflRj67T3EVkEp3+AStUBT0OA==;EndpointSuffix=core.windows.net";
var containerString = "myteststoragewithunique";

var client = new BlobContainerClient(connectionString, containerString);