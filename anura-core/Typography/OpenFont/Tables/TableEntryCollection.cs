using System.Collections.Generic;

namespace Anura.Typography.OpenFont.Tables {
    internal class TableEntryCollection {
        private Dictionary<string, TableEntry> _tables;

        public TableEntryCollection (int tableCount = 0) {
            if (tableCount > 0) {
                _tables = new Dictionary<string, TableEntry> (tableCount);
            } else {
                _tables = new Dictionary<string, TableEntry> ();
            }
        }

        public void AddEntry (TableEntry en) {
            _tables.Add (en.Name, en);
        }

        public bool TryGetTable (string tableName, out TableEntry entry) {
            return _tables.TryGetValue (tableName, out entry);
        }

        public void ReplaceTable (TableEntry table) {
            _tables[table.Name] = table;
        }
    }
}