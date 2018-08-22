using System.Collections.Generic;


namespace Code {

    public static class The {

        public static Repo <Snake> Snakes = new Repo <Snake> {
            Items = new HashSet <Snake> {
                new Snake (0, "Лох-1", default (Skin), "", new Program ()),
                new Snake (1, "Лох-2", default (Skin), "", new Program ())
            }
        };

    }

}