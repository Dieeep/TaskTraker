﻿using TaskTraker.Data.Models;

namespace TaskTraker.Services.Dtos
{
    public record GetBoardDto(string? Name, DateTime CreatedAt);

    public static class GetBoardDtoExtensions
    {
        public static GetBoardDto FromBoardToGetDto(this Board board) => new
         (
             Name: board.Name,
             CreatedAt: board.CreatedAt
         );

        public static void FromGetDtoToBoard(this GetBoardDto boardDto, Board board)
        {
            board.Name = boardDto.Name;
            board.CreatedAt = boardDto.CreatedAt;
        }
    }
}
