/**
 * $Id: IrcCommands.cs 77 2004-09-19 13:31:53Z meebey $
 * $URL: svn://svn.qnetp.net/smartirc/SmartIrc4net/tags/0.2.0/src/IrcCommands.cs $
 * $Rev: 77 $
 * $Author: meebey $
 * $Date: 2004-09-19 15:31:53 +0200 (Sun, 19 Sep 2004) $
 *
 * Copyright (c) 2003-2004 Mirco 'meebey' Bauer <mail@meebey.net> <http://www.meebey.net>
 * 
 * Full LGPL License: <http://www.gnu.org/licenses/lgpl.txt>
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace Meebey.SmartIrc4net
{
    /// <summary>
    ///
    /// </summary>
    public class IrcCommands: IrcConnection
    {
        public void Message(SendType type, string destination, string message, Priority priority)
        {
            switch(type) {
                case SendType.Message:
                    Privmsg(destination, message, priority);
                break;
                case SendType.Action:
                    Privmsg(destination, (char)1+"ACTION "+message+(char)1, priority);
                break;
                case SendType.Notice:
                    Notice(destination, message, priority);
                break;
                case SendType.CtcpRequest:
                    Privmsg(destination, (char)1+message+(char)1, priority);
                break;
                case SendType.CtcpReply:
                    Notice(destination, (char)1+message+(char)1, priority);
                break;
            }
        }

        public void Message(SendType type, string destination, string message)
        {
            Message(type, destination, message, Priority.Medium);
        }

        public void Pong(string data)
        {
            WriteLine(Rfc2812.Pong(data), Priority.Critical);
        }

        public void Pass(string password, Priority priority)
        {
            WriteLine(Rfc2812.Pass(password), priority);
        }

        public void Pass(string password)
        {
            WriteLine(Rfc2812.Pass(password));
        }

        public void User(string username, int usermode, string realname, Priority priority)
        {
            WriteLine(Rfc2812.User(username, usermode, realname), priority);
        }

        public void User(string username, int usermode, string realname)
        {
            WriteLine(Rfc2812.User(username, usermode, realname));
        }

        public void Privmsg(string destination, string message, Priority priority)
        {
            WriteLine(Rfc2812.Privmsg(destination, message), priority);
        }

        public void Privmsg(string destination, string message)
        {
            WriteLine(Rfc2812.Privmsg(destination, message));
        }

        public void Notice(string destination, string message, Priority priority)
        {
            WriteLine(Rfc2812.Notice(destination, message), priority);
        }

        public void Notice(string destination, string message)
        {
            WriteLine(Rfc2812.Notice(destination, message));
        }

        public void Join(string channel, Priority priority)
        {
            WriteLine(Rfc2812.Join(channel), priority);
        }

        public void Join(string channel)
        {
            WriteLine(Rfc2812.Join(channel));
        }

        public void Part(string channel, Priority priority)
        {
            WriteLine(Rfc2812.Part(channel), priority);
        }

        public void Part(string channel)
        {
            WriteLine(Rfc2812.Part(channel));
        }

        public void Part(string channel, string reason, Priority priority)
        {
            WriteLine(Rfc2812.Part(channel, reason), priority);
        }

        public void Part(string channel, string reason)
        {
            WriteLine(Rfc2812.Part(channel, reason));
        }

        public void Kick(string channel, string nickname, Priority priority)
        {
            WriteLine(Rfc2812.Kick(channel, nickname), priority);
        }

        public void Kick(string channel, string nickname)
        {
            WriteLine(Rfc2812.Kick(channel, nickname));
        }

        public void Kick(string channel, string nickname, string reason, Priority priority)
        {
            WriteLine(Rfc2812.Kick(channel, nickname, reason), priority);
        }

        public void Kick(string channel, string nickname, string reason)
        {
            WriteLine(Rfc2812.Kick(channel, nickname, reason));
        }

        public void List(string channel, Priority priority)
        {
            WriteLine(Rfc2812.List(channel), priority);
        }

        public void List(string channel)
        {
            WriteLine(Rfc2812.List(channel));
        }

        public void Names(string channel, Priority priority)
        {
            WriteLine(Rfc2812.Names(channel), priority);
        }

        public void Names(string channel)
        {
            WriteLine(Rfc2812.Names(channel));
        }

        public void Topic(string channel, Priority priority)
        {
            WriteLine(Rfc2812.Topic(channel), priority);
        }

        public void Topic(string channel)
        {
            WriteLine(Rfc2812.Topic(channel));
        }

        public void Topic(string channel, string newtopic, Priority priority)
        {
            WriteLine(Rfc2812.Topic(channel, newtopic), priority);
        }

        public void Topic(string channel, string newtopic)
        {
            WriteLine(Rfc2812.Topic(channel, newtopic));
        }

        public void Mode(string target, Priority priority)
        {
            WriteLine(Rfc2812.Mode(target), priority);
        }

        public void Mode(string target)
        {
            WriteLine(Rfc2812.Mode(target));
        }

        public void Mode(string target, string newmode, Priority priority)
        {
            WriteLine(Rfc2812.Mode(target, newmode), priority);
        }

        public void Mode(string target, string newmode)
        {
            WriteLine(Rfc2812.Mode(target, newmode));
        }

        public void Op(string channel, string nickname, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "+o "+nickname), priority);
        }

        public void Op(string channel, string nickname)
        {
            WriteLine(Rfc2812.Mode(channel, "+o "+nickname));
        }

        public void Deop(string channel, string nickname, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "-o "+nickname), priority);
        }

        public void Deop(string channel, string nickname)
        {
            WriteLine(Rfc2812.Mode(channel, "-o "+nickname));
        }

        public void Voice(string channel, string nickname, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "+v "+nickname), priority);
        }

        public void Voice(string channel, string nickname)
        {
            WriteLine(Rfc2812.Mode(channel, "+v "+nickname));
        }

        public void Devoice(string channel, string nickname, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "-v "+nickname), priority);
        }

        public void Devoice(string channel, string nickname)
        {
            WriteLine(Rfc2812.Mode(channel, "-v "+nickname));
        }

        public void Ban(string channel, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "+b"), priority);
        }

        public void Ban(string channel)
        {
            WriteLine(Rfc2812.Mode(channel, "+b"));
        }

        public void Ban(string channel, string hostmask, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "+b "+hostmask), priority);
        }

        public void Ban(string channel, string hostmask)
        {
            WriteLine(Rfc2812.Mode(channel, "+b "+hostmask));
        }

        public void Unban(string channel, string hostmask, Priority priority)
        {
            WriteLine(Rfc2812.Mode(channel, "-b "+hostmask), priority);
        }

        public void Unban(string channel, string hostmask)
        {
            WriteLine(Rfc2812.Mode(channel, "-b "+hostmask));
        }

        public void Invite(string nickname, string channel, Priority priority)
        {
            WriteLine(Rfc2812.Invite(nickname, channel), priority);
        }

        public void Invite(string nickname, string channel)
        {
            WriteLine(Rfc2812.Invite(nickname, channel));
        }

        public void Nick(string newnickname, Priority priority)
        {
            WriteLine(Rfc2812.Nick(newnickname), priority);
        }

        public void Nick(string newnickname)
        {
            WriteLine(Rfc2812.Nick(newnickname));
        }

        public void Who(string target, Priority priority)
        {
            WriteLine(Rfc2812.Who(target), priority);
        }

        public void Who(string target)
        {
            WriteLine(Rfc2812.Who(target));
        }

        public void Whois(string target, Priority priority)
        {
            WriteLine(Rfc2812.Whois(target), priority);
        }

        public void Whois(string target)
        {
            WriteLine(Rfc2812.Whois(target));
        }

        public void Whowas(string target, Priority priority)
        {
            WriteLine(Rfc2812.Whowas(target), priority);
        }

        public void Whowas(string target)
        {
            WriteLine(Rfc2812.Whowas(target));
        }

        public void Quit(Priority priority)
        {
            WriteLine(Rfc2812.Quit(), priority);
        }

        public void Quit()
        {
            WriteLine(Rfc2812.Quit());
        }

        public void Quit(string reason, Priority priority)
        {
            WriteLine(Rfc2812.Quit(reason), priority);
        }

        public void Quit(string reason)
        {
            WriteLine(Rfc2812.Quit(reason));
        }
    }
}
