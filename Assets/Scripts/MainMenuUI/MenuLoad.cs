using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.IO.Compression;
using System;
using UnityEngine.SceneManagement;

public class MenuLoad : MonoBehaviour
{
    /*private int counter = 0;
    private List<PlayerData> saveData;
    [SerializeField]
    private Text textBox;
    private string stringPlayTime(int seconds){
        int mins = seconds / 60; 
        int hours = mins / 60; 
        mins %= 60;
        return hours + ":" + mins.ToString("D2");
    }
    private string getSaveData() => "Save Name: " + saveData[counter].absoluteWorldName + 
                                    "\nWorld Name: " + saveData[counter].worldName +
                                    "\nVersion: " + saveData[counter].version +
                                    "\nLast Saved: " + (saveData[counter].lastSaved == -1 ? "Corrupted File" : DateTime.FromFileTimeUtc(saveData[counter].lastSaved).ToString()) +
                                    "\nTime Played: " + stringPlayTime(saveData[counter].absoluteTime) +
                                    "\nSize: " + saveData[counter].fileSize.ToString("n2") + " mb" +
                                    "\nCan Safely Open: " + (SaveUtility.canPortSaveFile(saveData[counter].version) ? "Yes" : "No");

    public void init(){
        saveData = new List<PlayerData>();
        string[] saveFiles = Directory.GetDirectories(SaveUtility.SaveDir);
        for(int i = 0; i < saveFiles.Length; i++){
            saveFiles[i] = saveFiles[i].Substring(saveFiles[i].LastIndexOf('/') + 1);
            SaveUtility.updateSavePath(saveFiles[i]);
            if(File.Exists(SaveUtility.PlayerData)){
                PlayerData playerData = SaveUtility.readFile<PlayerData>(SaveUtility.PlayerData);
                playerData.absoluteWorldName = saveFiles[i];
                saveData.Add(playerData);
            }
        }

        string[] steamSaves = Directory.GetFiles(SaveUtility.SteamSave);
        for(int i = 0; i < steamSaves.Length; i++){
            string steamSaveName = steamSaves[i].Substring(steamSaves[i].LastIndexOf('/') + 1);
            if(steamSaveName.Contains(".sce")){
                steamSaveName = steamSaveName.Substring(0, steamSaveName.LastIndexOf('.'));
                if(!hasNameInSaves(steamSaveName)){
                    Debug.Log("FOUND STEAM SAVE, UNPACKING: " + steamSaveName);
                    SaveUtility.updateSavePath(steamSaveName);
                    ZipFile.ExtractToDirectory(steamSaves[i], SaveUtility.SavePath);
                    PlayerData playerData = SaveUtility.readFile<PlayerData>(SaveUtility.PlayerData);
                    saveData.Add(playerData);
                }
            }
        }

        for (int i = 0; i < saveData.Count; i++) {
            for (int j = 0; j < saveData.Count - 1; j++) {
                if(saveData[j + 1].greaterThen(saveData[j])){
                    PlayerData temp = saveData[j + 1];
                    saveData[j + 1] = saveData[j];
                    saveData[j] = temp;
               }
            }
        }

        counter = 0;

        if(saveData.Count == 0) 
            textBox.text = "No save files found";
        else
            textBox.text = getSaveData();
            
    }
    private void sortSaveFiles(){

    }
    
    private bool hasNameInSaves(string name){
        for(int i = 0; i < saveData.Count; i++)
            if(saveData[i].absoluteWorldName == name)
                return true;
        return false;
    }
    public void deleteWorld(){
        string zipPath = SaveUtility.SteamSave + saveData[counter].absoluteWorldName + ".sce";
        if(File.Exists(zipPath))
            File.Delete(zipPath);

        SaveUtility.updateSavePath(saveData[counter].absoluteWorldName);
        SaveUtility.DeleteDirectory(SaveUtility.SavePath);
        saveData.RemoveAt(counter);


        nextWorld();
        lastWorld();
    }

    public void lastWorld(){
        if(saveData.Count == 0) 
            return;
        counter--;
        if(counter < 0)
            counter = saveData.Count - 1;
        textBox.text = getSaveData();
    }
    public void nextWorld(){
        if(saveData.Count == 0) 
            return;
        counter++;
        if(counter >= saveData.Count)
            counter = 0;
        textBox.text = getSaveData();
    }

    public void loadGame(){
        if(saveData.Count == 0) 
            return;
        SaveUtility.updateSavePath(saveData[counter].worldName);

        if(saveData[counter].worldName != saveData[counter].absoluteWorldName){
            string worldPath = SaveUtility.SavePath;
            if(Directory.Exists(SaveUtility.SavePath))
                SaveUtility.DeleteDirectory(SaveUtility.SavePath);
            
            SaveUtility.updateSavePath(saveData[counter].absoluteWorldName);
            SaveUtility.CopyFilesRecursively(SaveUtility.SavePath, worldPath);

            SaveUtility.updateSavePath(saveData[counter].worldName);

            PlayerData playerData = SaveUtility.readFile<PlayerData>(SaveUtility.PlayerData);
            playerData.absoluteWorldName = playerData.worldName;
            SaveUtility.writeFile<PlayerData>(SaveUtility.PlayerData, playerData);

            Debug.Log("Overriding save " + worldPath);
        }
        SceneManager.LoadScene("CoreGame");
    }*/
}
