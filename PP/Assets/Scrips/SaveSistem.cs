using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
public class SaveSistem
{ 
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saves.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerDataSV data = new PlayerDataSV(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerDataSV LoadPlayer()
    {
        string path = Application.persistentDataPath + "/saves.txt";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream (path, FileMode.Open);

            PlayerDataSV data = formatter.Deserialize(stream) as PlayerDataSV;

            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
