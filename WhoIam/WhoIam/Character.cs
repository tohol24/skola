namespace WhoIam
{
    internal class Character
    {
        readonly int id;
        readonly string name = "";
        readonly int yearOfBirth = 0;
        readonly string job = "";

        public Character(int id, string name, int yearOfBirth, string job)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.job = job;
        }
    }
}
