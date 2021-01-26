using DAL.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class CommentService : ICommentService
    {
        ICommentRepository _commentRepo;
        public CommentService(ICommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
        }
        public int Insert(Comment Value)
        {
            return _commentRepo.Insert(Value.CommentDALToCommentDTO());
        }
    }
}
