// Copyright 2016-2019 Karat, Inc.  Please do not distribute or republish.

using System;
using System.Collections;
using System.Collections.Generic;



class Solution
{

    
    static void Main(string[] args)
    {
        String[] counts = {"255,yahoo.com" , "500,google.com.uk"};
        
        ClickCount(user0, user1);
        
    }
    
    // Your function here:
    public static Dictionary<string, int> ClickCount(string[] counts){
        
        var dict = new Dictionary<string, int>(); 
        
        foreach(var count in counts){
            string[] words = count.Split(',');
            int clicks = Int32.Parse(words[0]);
           // Console.WriteLine(clicks);
            string[] domains = words[1].Split('.');
            
            string key = "";
            for(int i =domains.Length-1; i>=0; i--){
               // Console.WriteLine(domains[i]);
                if(i != domains.Length - 1)
                    key =  domains[i] + "." + key;
                else
                    key = domains[i];
                
                if(dict.ContainsKey(key))
                    dict[key] += clicks;
                else
                    dict[key] = clicks;
            }
            
           
        }
        Console.WriteLine(dict);
        foreach (var kvp in dict)
        {
            //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        
        return dict;
    }
    
}


