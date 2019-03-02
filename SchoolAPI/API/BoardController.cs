using SchoolAPI.BusinessLayer;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolAPI.API
{
    public class BoardController : ApiController
    {
        [HttpPost]
        public object AddBoard([FromBody]BoardParam obj)
        {
            try
            {
                BoardBussiness save = new BoardBussiness();
                var result = save.SaveBoard(obj);
                return result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }



        }
        [HttpPost]
        public object GetBoardInfo(UserCredential uc)
        {
            try
            {
                BoardBussiness board = new BoardBussiness();
                var Result = board.GetBoard(uc);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object GetSingleBoardInfo(BoardParam b)
        {
            try
            {
                BoardBussiness board = new BoardBussiness();
                var Result = board.GetSingleBoard(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object UpdateBoard(BoardParam b)
        {
            try
            {
                BoardBussiness board = new BoardBussiness();
                var Result = board.BoardUpdate(b);

                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };

            }

        }
        [HttpPost]
        public object DeleteBoard([FromBody] BoardParam PM)
        {
            try
            {
                BoardBussiness b = new BoardBussiness();
                var Result = b.DeleteBoard(PM);
                return Result;
            }
            catch (Exception e)
            {
                return new Error() { IsError = true, Message = e.Message };
            }
        }
    }
}
