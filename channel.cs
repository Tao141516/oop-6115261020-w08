using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261020_w08
{
    class channel
    {
        private string nameChannel;
        private string followChannel;
        private string subscribeChannel;
        private clip clipChannel;

        public string NameChannel
        {
            get { return nameChannel; }
            set { nameChannel = value; }
        }
        public string FollowChannel
        {
            get { return followChannel; }
            set { followChannel = value; }
        }
        public string SubscribeChannel
        {
            get { return subscribeChannel; }
            set { subscribeChannel = value; }
        }
        public clip ClipChannel
        {
            get { return clipChannel; }
            set { clipChannel = value; }
        }
        public channel (string m,string f,string s,clip am)
        {
            this.NameChannel = m;
            this.FollowChannel = f;
            this.SubscribeChannel = s;
            this.ClipChannel = am;
        }
        public override string ToString()
        {
            return this.NameChannel + " " +
                   this.FollowChannel + " " +
                   this.SubscribeChannel + " " +
                   this.ClipChannel.NameClip + " " +
                   this.ClipChannel.TimeClip + " " +
                   this.ClipChannel.ViewClip;
        }
    }
}
