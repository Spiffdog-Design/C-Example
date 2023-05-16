using App.Common;

namespace App.Potions {
    public class Health: ItemBase, IUsable {
        public Health(int value): base("Health", $"This is a {value}hp health potion.") {
            Value = value;
        }

        public int Value { get; set; }

        public void Use() {
            // do something with this.Value here.
        }
    }
}