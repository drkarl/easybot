﻿using System;

namespace BtcE.Utils {
	public static class UnixTime {
		static DateTime unixEpoch = new DateTime(1970, 1, 1);
		public static UInt32 Now {get {return GetFromDateTime(DateTime.UtcNow);}}
		public static UInt32 GetFromDateTime(DateTime d) {return (UInt32)( d - unixEpoch ).TotalSeconds;}
		public static DateTime ConvertToDateTime(UInt32 unixtime) {return unixEpoch.AddSeconds(unixtime);}
	}
}
