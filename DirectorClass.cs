namespace Builder
{
    public class DirectorClass
    {
        private IGenerateDocument _document = null;

        public IGenerateDocument BuildDocument(IGenerateDocument document)
        {
            _document = document;
            _document.GatherDate();
            _document.MapData();
            _document.AddDocumentSetting();
            _document.CreateDocument();

            return _document;
        }
    }
}