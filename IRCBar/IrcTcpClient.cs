/**
 * $Id: IrcTcpClient.cs 77 2004-09-19 13:31:53Z meebey $
 * $URL: svn://svn.qnetp.net/smartirc/SmartIrc4net/tags/0.2.0/src/IrcTcpClient.cs $
 * $Rev: 77 $
 * $Author: meebey $
 * $Date: 2004-09-19 15:31:53 +0200 (Sun, 19 Sep 2004) $
 *
 * Copyright (c) 2003 Mirco 'meebey' Bauer <mail@meebey.net> <http://www.meebey.net>
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

using System.Net.Sockets;

namespace Meebey.SmartIrc4net
{
    /// <summary>
    ///
    /// </summary>
    public class IrcTcpClient: TcpClient
    {
        public Socket Socket
        {
            get {
                return Client;
            }
        }
    }
}
