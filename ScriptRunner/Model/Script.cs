using System.Collections.Generic;

namespace ScriptRunner.Model
{
    public struct Script
    {
        public string Path { get; set; }

        private Dictionary<string, string> _parameters;
        public Dictionary<string, string> Parameters => 
            _parameters 
            ??= new Dictionary<string, string>();
        
        
    }
}