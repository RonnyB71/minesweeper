using Minesweeper.Models;
using System;
using System.Linq;

namespace Minesweeper.Implementation
{
    public class StaticBoardGenerator : IBoardGenerator
    {
        private readonly string _boardDefinition;

        public StaticBoardGenerator(string boardDefinition) 
        {
            if (string.IsNullOrWhiteSpace(boardDefinition))
                throw new ArgumentException("Board definition cannot be null or empty.");

            var rows = boardDefinition.Split(',');
            if (rows.Length == 0) 
                throw new ArgumentException("Board must have at least one row.");


            _boardDefinition = boardDefinition;
        }

        public Board GenerateBoard()
        {
          
            return new Board(0, 0, 0); 
        }
    }
}
