using System;
using System.Collections.Generic;
using System.IO;

// To execute C#, please define "static void Main" on a class
// named Solution.

/*
Input: `"/foo"` 

    - /foo
      - /images
        - /foo.png  <------.
      - /temp              | same file contents
        - /baz             |
          - /that.foo  <---|--.
      - /bar.png  <--------'  |
      - /file.tmp  <----------| same file contents
      - /other.temp  <--------'
      - /blah.txt

Output:

      [
         ['/foo/bar.png', '/foo/images/foo.png'],
         ['/foo/file.tmp', '/foo/other.temp', '/foo/temp/baz/that.foo']
      ]
*/
class Solution
{
    static void Main(string[] args)
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello, World");
        }
    }
    
    public List<List<string> FindDuplicates(string path){
        
        string[] files = Directory.GetFiles(path); //Get All recursive files
        string[] directories = Directory.GetDirectories(path);
        var allFiles new List<string>();
        
        var queue = new Queue<string>();
        var path = "";
        queue.Enque(path);
        
        while(queue.Count > 0){
            path = queue.Dequeue();
            directories = Directory.GetDirectories(path)
                
            foreach(var d in directories){
                queue.Enqueue(d);
            }
            
            files = Directory.GetFiles(path);
            foreach(var f in files){
                   allFiles.Add(f);
            }
        }

        
        
        var map = new Dictionary<string, List<string>>(); // key is content, value is list of file names
        var mapFileSize = new Dictionary<int, List<string>>(); // key is file size, value is file name
        
        foreach(var file in allFiles)
        {
            
            var fileSize = file.GetSize();
            var fileList =  new List<string>();
            
            if(!mapFileSize.ContainsKey(fileSize)
                mapFileSize[fileSize] = file;   
            else
                mapFileSize[fileSize] =  fileList.Add(file);

        }
               
        foreach(var item in mapFileSize)
        {
            if(item.Value.Length > 1)
            {
                foreach(var file in item.Value)
                {
                    
                    string UnHashedContents = File.ReadAllText(file);
                    string contents = Hash86(UnHashedContents);

                    var list =  new List<string>();
                    if(!map.ContainsKey(contents)){
                        map[contents] = list.Add(file);
                    }
                    else{
                        map[contents] = map[contents].Add(file);
                    }
                }

            }
        }
            
        
        var duplicates = new List<List<string>();
        
        foreach(var item in map){
            if(item.Value.Length > 1)
                duplicates.Add(item.Value)
        }
        
        return duplicates;
        
    }
}
