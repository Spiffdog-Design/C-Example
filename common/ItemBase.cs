namespace App.Common {
    public abstract class ItemBase {
        public ItemBase(string name, string description) {
            Name = name;
            Description = description
        }

        public string Description { get; set; }
        public string Name { get; set; }
    }
}