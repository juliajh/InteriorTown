using System;
using UnityEngine;
using UnityEngine.UI;
using check;
using Cysharp.Threading.Tasks;

namespace FrostweepGames.Plugins.WebGLFileBrowser.Examples
{
    public class ChoseImage : MonoBehaviour
    {
        //public SpriteRenderer imageSprite;
        public string serverUrl;
        public Button sendServer;

        /// <summary>
        /// 
        /// </summary>
        public Image contentImage;

        public Button openFileDialogButton;

        public Button saveOpenedFileButton;

        public Button cleanupButton;

        public InputField filterOfTypesField;

        public Text fileNameText,
                    fileInfoText;

        private string _enteredFileExtensions;

        private File[] _loadedFiles;

        private void Start()
        {
            openFileDialogButton.onClick.AddListener(OpenFileDialogButtonOnClickHandler);
            saveOpenedFileButton.onClick.AddListener(SaveOpenedFileButtonOnClickHandler);
            cleanupButton.onClick.AddListener(CleanupButtonOnClickHandler);
            filterOfTypesField.onValueChanged.AddListener(FilterOfTypesFieldOnValueChangedHandler);

            WebGLFileBrowser.FilesWereOpenedEvent += FilesWereOpenedEventHandler;
            WebGLFileBrowser.FilePopupWasClosedEvent += FilePopupWasClosedEventHandler;
            WebGLFileBrowser.FileOpenFailedEvent += FileOpenFailedEventHandler;
            WebGLFileBrowser.FileWasSavedEvent += FileWasSavedEventHandler;
            WebGLFileBrowser.FileSaveFailedEvent += FileSaveFailedEventHandler;

            // if you want to set custom localization for file browser popup -> use that function:
            // WebGLFileBrowser.SetLocalization(LocalizationKey.DESCRIPTION_TEXT, "Select file for loading:");
        }

        private void OnDestroy()
        {
            WebGLFileBrowser.FilesWereOpenedEvent -= FilesWereOpenedEventHandler;
            WebGLFileBrowser.FilePopupWasClosedEvent -= FilePopupWasClosedEventHandler;
            WebGLFileBrowser.FileOpenFailedEvent -= FileOpenFailedEventHandler;
            WebGLFileBrowser.FileWasSavedEvent -= FileWasSavedEventHandler;
            WebGLFileBrowser.FileSaveFailedEvent -= FileSaveFailedEventHandler;
        }

        private void SaveOpenedFileButtonOnClickHandler()
        {
            if (_loadedFiles != null && _loadedFiles.Length > 0)
                WebGLFileBrowser.SaveFile(_loadedFiles[0]);

            // if you want to save custom file use this flow:
            //File file = new File()
            //{
            //    fileInfo = new FileInfo()
            //    {
            //        fullName = "Myfile.txt"
            //    },
            //    data = System.Text.Encoding.UTF8.GetBytes("my text content!")
            //};
            //WebGLFileBrowser.SaveFile(file);
        }

        private void OpenFileDialogButtonOnClickHandler()
        {
            // you could paste types like: ".png,.jpg,.pdf,.txt,.json"
            // WebGLFileBrowser.OpenFilePanelWithFilters(".png,.jpg,.pdf,.txt,.json");
            WebGLFileBrowser.OpenFilePanelWithFilters(WebGLFileBrowser.GetFilteredFileExtensions(_enteredFileExtensions));
        }

        private void CleanupButtonOnClickHandler()
        {
            _loadedFiles = null; // you have to remove link to file and then GarbageCollector will think that there no links to that object
            saveOpenedFileButton.gameObject.SetActive(false);
            cleanupButton.gameObject.SetActive(false);

            fileInfoText.text = string.Empty;
            fileNameText.text = string.Empty;
            contentImage.color = new Color(1, 1, 1, 0);
            contentImage.sprite = null;

            WebGLFileBrowser.FreeMemory(); // free used memory and destroy created content
        }

        private void FilesWereOpenedEventHandler(File[] files)
        {
            _loadedFiles = files;

            if (_loadedFiles != null && _loadedFiles.Length > 0)
            {
                var file = _loadedFiles[0];

                //fileNameText.text = file.fileInfo.name;
                //fileInfoText.text = $"File name: {file.fileInfo.name}\nFile extension: {file.fileInfo.extension}\nFile size: {file.fileInfo.SizeToString()}";
                //fileInfoText.text += $"\nLoaded files amount: {files.Length}";

                //saveOpenedFileButton.gameObject.SetActive(true);
                //cleanupButton.gameObject.SetActive(true);

                if (file.IsImage())
                {
                    contentImage.color = new Color(1, 1, 1, 1);
                    contentImage.sprite = file.ToSprite(); // dont forget to delete unused objects to free memory!

                    WebGLFileBrowser.RegisterFileObject(contentImage.sprite); // add sprite with texture to cache list. should be used with  WebGLFileBrowser.FreeMemory() when its no need anymore
                    SendFile();



                }
                else
                {
                    contentImage.color = new Color(1, 1, 1, 0);
                }

                if (file.IsText())
                {
                    string content = file.ToStringContent();
                    //fileInfoText.text += $"\nFile content: {content.Substring(0, Mathf.Min(30, content.Length))}";
                }
            }
        }



        GameObject particel;
        public async UniTaskVoid SendFile()
        {
            var response = await ImageUploader
                .Initialize()
                .SetTexture(contentImage.sprite.texture)
                .SetFieldName("file")
                .SetFileName("file")
                .SetUrl("/ReturnFurnitureClass")
                .SetType(ImageType.JPG)
                .OnError(error => Debug.Log(error))
                .OnComplete(text => Debug.Log(text))
                .StartUploading();
            
            int ans=(int)(FurnitureType)Enum.Parse(typeof(FurnitureType), response["Data"]);
            UI_CarrotWrite.Instance.m_CategoryText.value = ans;
            //FurnitureManager.Instance.changePanelParticle
            particel= Instantiate(FurnitureManager.Instance.changePanelParticle,new Vector3(1.51f,2.75f,0),Quaternion.identity);
            //particel.transform.SetParent(UI_CarrotWrite.Instance.m_CategoryText.transform);
            particel.SetActive(true);

        }
        
        public void StartBtn()
        {
            //print("aa");
            ImageUploader
                .Initialize()
                //.SetUrl(serverUrl)
                //.SetTexture(imageSprite.sprite.texture)
                .SetTexture(contentImage.sprite.texture)
                .SetFieldName("file")
                .SetFileName("file")
                .SetType(ImageType.JPG)
                .OnError(error => Debug.Log(error))
                .OnComplete(text => Debug.Log(text))
                .Upload();

            /* ImageUploader
                 .Initialize()
                 .SetUrl(serverUrl)
                 .SetTexture(imageSprite.sprite.texture)
                 .SetFieldName("file")
                 .Upload();*/
        }

        private void FilePopupWasClosedEventHandler()
        {
            if (_loadedFiles == null)
                saveOpenedFileButton.gameObject.SetActive(false);
        }

        private void FileWasSavedEventHandler(File file)
        {
            Debug.Log($"file {file.fileInfo.fullName} was saved");
        }

        private void FileSaveFailedEventHandler(string error)
        {
            Debug.Log(error);
        }

        private void FileOpenFailedEventHandler(string error)
        {
            Debug.Log(error);
        }

        private void FilterOfTypesFieldOnValueChangedHandler(string value)
        {
            _enteredFileExtensions = value;
        }
    }
}