using System.IO;

class FileAndDictonary
{
    public void LearnFilesAndFolders()
    {
        // 
        var folderPath = @"F:\.NetTraining\.NET-Training-Prakash\Fundamentals\TestFiles";
        var filePath = @$"{folderPath}\test.txt";
        File.WriteAllText(filePath, "Hello World!");

        var folder = @$"{folderPath}\test";
        Directory.CreateDirectory(folder);

        // Create a folder with name "A" somewhere and create a text file a.file inside it.

        var folder1 = @$"{folderPath}\A";         
        Directory.CreateDirectory(folder1);
        Directory.CreateDirectory(folderPath + "\\A");
        File.WriteAllText(folder1 + "\\a.txt", "Hello Nepal");




    }
}