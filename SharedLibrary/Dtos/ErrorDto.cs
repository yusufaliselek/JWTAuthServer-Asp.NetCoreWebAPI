﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; } = new List<string>();

        public bool IsShow { get; set; }


        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors; // burası sıkıntı olabilir E yi büyüt
            IsShow = isShow;
        }
    }
}
