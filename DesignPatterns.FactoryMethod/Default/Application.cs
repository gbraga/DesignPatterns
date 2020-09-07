using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Default.Framework
{
    // Faz o papel de Creator
    public abstract class Application
    {
        IList<Document> docs = new List<Document>();

        // Poderia ser uma interface IDocument
        // M�todo f�brica que delega a quem herdar
        // implementa��o do tipo concreto
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
