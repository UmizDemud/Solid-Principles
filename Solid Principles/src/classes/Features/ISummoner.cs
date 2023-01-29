using Solid_Principles.src.classes.Prefabs;

namespace Solid_Principles.classes.ObjectContext.Features
{
    interface ISummoner
    {
        public Dictionary<string, Func<CharacterBase>> summons { get; set; } // = new Dictionary<string, Func<CharacterBase>>() {
                                                                       //   warewolf: () => new Warewolf(),
                                                                       //   vampire: () => new Vampire(),
                                                                       //   harpie: () => new Harpie()
                                                                       // }
        public void summon(int x, int y, string name)
        {
            summons[name]();
        }
    }
}
