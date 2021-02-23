# Azure Functions

A demo repository used for an [Edinburgh Azure User Group](https://www.meetup.com/Edinburgh-Azure-User-Group/) talk
/ hands on with Azure Functions, showing the capabilities of Functions without the need for an Azure Subscription.

Demos the following triggers:
 - HttpTrigger
 - QueueTrigger
 - BlobTrigger

and also shows a Queue output binding in conjunction with an HTTP Trigger, as well as using the Azure Storage Explorer.

# How to use

In order to run locally, ensure the following tools are installed:
 - [Azure Functions Core Tools](https://go.microsoft.com/fwlink/?linkid=2135274)
 - [Azure Storage Emulator](https://go.microsoft.com/fwlink/?linkid=717179&clcid=0x409)
 - (Optionally) [Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/)

Once done and the repository has been cloned, open a command prompt at the root of the repository and run

```func start```

which will start up all the triggers. You can then hit the HTTP Trigger with a browser on the URL similar to
http://localhost:7071/api/HttpFunction.

The queue and blob triggers are most interactive when using the Azure Storage Explorer to create blobs/queue messages to trigger the functions.