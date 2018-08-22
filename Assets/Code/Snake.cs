namespace Code {

    public class Snake {

        public readonly int Id;
        public string Name;
        public string Info;
        public Skin Skin;
        public Program Program;
        
        
        public Snake (int id, string name, Skin skin, string info, Program program) {
            Id = id;
            Name = name;
            Info = info;
            Skin = skin;
            Program = program;
        }

    }


}