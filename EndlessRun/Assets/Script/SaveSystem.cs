using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem  {

    public static void SavePlayer(GameManagerController player) {

        BinaryFormatter formater = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path , FileMode.Create);

        PlayerData data = new PlayerData(player);

        formater.Serialize(stream,data);

        Debug.Log(data.Score);
    
        stream.Close();
    }


    public static PlayerData loadPlayer(GameManagerController player) {

        string path = Application.persistentDataPath + "/player.fun";

        if (File.Exists(path))
        {
            BinaryFormatter formater = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);

            PlayerData data = formater.Deserialize(stream) as PlayerData;

            player.ValidLoad = true;
            
            Debug.Log(data.Score);
            stream.Close();

            return data;
        }
        else {
            Debug.Log("save not found");
            player.ValidLoad = false;
            return null;
        }

    }
}
