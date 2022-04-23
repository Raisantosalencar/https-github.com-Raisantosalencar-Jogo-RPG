namespace Jogo_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string v)
        {
        }

        public BlackWizard (string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {



        }
        public override string Attack()
            {
                return this.Name + "Atacou com cajado";
            }
    }
    }
