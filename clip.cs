using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261020_w08
{
    class clip
    {
        private string nameClip;
        private string timeClip;
        private string viewClip;
        private string likeClip;
        private string commentClip;

        public string NameClip
        {
            get { return nameClip; }
            set { nameClip = value; }
        }
        public string TimeClip
        {
            get { return timeClip; }
            set { timeClip = value; }
        }
        public string ViewClip
        {
            get { return viewClip; }
            set { viewClip = value; }
        }
        public string LikeClip
        {
            get { return likeClip; }
            set { likeClip = value; }
        }
        public string CommentClip
        {
            get { return commentClip; }
            set { commentClip = value; }
        }
        public clip(string n, string t, string v, string l, string c)
        {
            this.NameClip = n;
            this.TimeClip = t;
            this.ViewClip = v;
            this.LikeClip = l;
            this.CommentClip = c;
        }
        public override string ToString()
        {
            return this.NameClip + " " +
                   this.TimeClip + " " +
                   this.ViewClip + " " +
                   this.LikeClip + " " +
                   this.CommentClip;
        }
    }
}
