﻿namespace Svg.Model
{
    public class ClipPathPictureCommand : PictureCommand
    {
        public Path Path { get; set; }
        public ClipOperation Operation { get; set; }
        public bool Antialias { get; set; }

        public ClipPathPictureCommand(Path path, ClipOperation operation, bool antialias)
        {
            Path = path;
            Operation = operation;
            Antialias = antialias;
        }
    }
}