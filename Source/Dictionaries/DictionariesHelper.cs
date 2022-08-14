using System.Collections.Generic;
using Move = Logic.Enums.Move;

namespace Logic.Dictionaries
{
	public static class DictionariesHelper
	{
		public static Dictionary<Move, string> Movement
		= new Dictionary<Move, string>
		{
			{Move.Up       , "move_up"   },
			{Move.Down     , "move_down" },
			{Move.Left     , "move_left" },
			{Move.Right    , "move_right"},
			{Move.UnMapped , "unmapped"  },
		};
	}
}