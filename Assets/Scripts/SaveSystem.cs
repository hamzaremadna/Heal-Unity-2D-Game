using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    // Start is called before the first frame update
    public static void Save(shop player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path =  Application.persistentDataPath + "/player.cc";
        FileStream stream = new FileStream(path,FileMode.Create);

        PlayerData data = new PlayerData(player); 
        formatter.Serialize(stream, data);
        stream.Close();
    }




    // Update is called once per frame
    public static PlayerData Load()
    {
                string path =  Application.persistentDataPath + "/player.cc";
          
                            BinaryFormatter formatter = new BinaryFormatter();
                                    FileStream stream = new FileStream(path,FileMode.Open);
                                    PlayerData data = formatter.Deserialize(stream) as PlayerData;
                                    stream.Close();
                                    return data;
           

    }
}
