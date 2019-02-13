namespace Builder
{
    public interface IGenerateDocument
    {
        DataFromDb GatherDate();
        MappedData MapData();
        void AddDocumentSetting();
        void CreateDocument();
    }
}