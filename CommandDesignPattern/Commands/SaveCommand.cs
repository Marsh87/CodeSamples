using CommandDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class SaveCommand : Interfaces.ICommand
    {
        private Document _document;
        public SaveCommand(Document document)
        {
            _document = document;
        }
        public void Execute()
        {
            _document.Save();
        }
    }
}
