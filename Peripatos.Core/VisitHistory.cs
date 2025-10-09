using System;
using System.Collections.Generic;
using System.Linq;

namespace Peripatos.Core
{
    public class VisitHistory
    {
        private readonly Dictionary<string, DateTime> _visitedForms;
        private readonly List<string> _availableForms;

        public VisitHistory()
        {
            _visitedForms = new Dictionary<string, DateTime>();
            _availableForms = new List<string>
            {
                "Beaches_Form", 
                "Sights_Form",
                "Restaurant_Form",
                "Presentation_Form"
            };
        }

        public Dictionary<string, DateTime> VisitedForms { get { return _visitedForms; } }
        public List<string> AvailableForms { get { return _availableForms; } }

        public void MarkFormVisited(string formName)
        {
            if (_availableForms.Contains(formName))
            {
                _visitedForms[formName] = DateTime.Now;
            }
        }

        public bool HasVisitedForm(string formName)
        {
            return _visitedForms.ContainsKey(formName);
        }

        public DateTime? GetLastVisitTime(string formName)
        {
            if (_visitedForms.TryGetValue(formName, out DateTime time))
                return time;
            return null;
        }

        public void ClearHistory()
        {
            _visitedForms.Clear();
        }

        public void LoadFromDatabase(Dictionary<string, DateTime> dbHistory)
        {
            _visitedForms.Clear();
            foreach (var entry in dbHistory)
            {
                if (_availableForms.Contains(entry.Key))
                {
                    _visitedForms[entry.Key] = entry.Value;
                }
            }
        }

        public string GetFormDisplayName(string formName)
        {
            if (formName == "Beaches_Form") return "Παραλίες";
            if (formName == "Sights_Form") return "Αξιοθέατα";
            if (formName == "Restaurant_Form") return "Εστιατόρια";
            if (formName == "Presentation_Form") return "Παρουσίαση";
            return formName;
        }

        public int GetVisitedCount() 
        { 
            return _visitedForms.Count; 
        }
        
        public int GetTotalFormsCount() 
        { 
            return _availableForms.Count; 
        }
        
        public double GetCompletionPercentage() 
        { 
            return (double)GetVisitedCount() / GetTotalFormsCount() * 100; 
        }
    }
}