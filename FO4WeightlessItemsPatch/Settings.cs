using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FO4WeightlessItemsPatch
{
    internal class Settings
    {
        [MaintainOrder] [SettingName("Ingestibles")]
        public bool Ingestibles = true;
        [MaintainOrder] [SettingName("Ammunition")]
        public bool Ammunition = true;
        [MaintainOrder] [SettingName("Books/Magazines")]
        public bool BooksMagazines = true;
        [MaintainOrder] [SettingName("Keys/Passcards")]
        public bool KeysPasscards = true;
        [MaintainOrder] [SettingName("Notes/Holotapes")]
        public bool NotesHolotapes = true;
        [MaintainOrder] [SettingName("Misc (Mods only)")]
        public bool Mods = true;
        [MaintainOrder] [SettingName("Misc (All)")]
        public bool Misc = false;
        [MaintainOrder] [SettingName("Armors")]
        public bool Armors = false;
        [MaintainOrder] [SettingName("Weapons")]
        public bool Weapons = false;
    }
}