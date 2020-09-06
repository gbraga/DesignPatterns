using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Framework
{
    public abstract class Application
    {
        IList<Document> docs = new List<Document>();

        public abstract Document CreateDocument();

        public Document NewDocument()
        {
            var doc = CreateDocument();

            docs.Add(doc);

            return doc.Open();
        }

        public Document OpenDocument(Document doc) => doc.Open();
    }
}
