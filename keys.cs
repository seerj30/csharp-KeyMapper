public KeyMapper()
        {
            AddKeyMap(Keys.Back, " {Backspace} ");
            AddKeyMap(Keys.Return, " {ENTER} " + Environment.NewLine);
            AddKeyMap(Keys.Capital, string.Empty);
            AddKeyMap(Keys.Space, " ");
            AddKeyMap(Keys.Tab, "\t");
            AddKeyMap(Keys.LMenu, " {ALT} ");
            AddKeyMap(Keys.Alt, " {ALT} ");
            AddKeyMap(Keys.LWin, string.Empty);
            AddKeyMap(Keys.RWin, string.Empty);
            AddKeyMap(Keys.NumLock, string.Empty);
            AddKeyMap(Keys.Scroll, string.Empty);
            AddKeyMap(Keys.PrintScreen, " {PRINTSCREEN} ");
            AddKeyMap(Keys.Control, string.Empty);
            AddKeyMap(Keys.Pause, string.Empty);
            AddKeyMap(Keys.PageDown, string.Empty);
            AddKeyMap(Keys.PageUp, string.Empty);
            AddKeyMap(Keys.Insert, string.Empty);
            AddKeyMap(Keys.Home, " {HOME} ");
            AddKeyMap(Keys.End, " {END} ");
            AddKeyMap(Keys.LShiftKey, string.Empty);
            AddKeyMap(Keys.RShiftKey, string.Empty);

            AddKeyMap(Keys.D0, "0", ")");
            AddKeyMap(Keys.D1, "1", "!");
            AddKeyMap(Keys.D2, "2", "@");
            AddKeyMap(Keys.D3, "3", "#");
            AddKeyMap(Keys.D4, "4", "$");
            AddKeyMap(Keys.D5, "5", "%");
            AddKeyMap(Keys.D6, "6", "^");
            AddKeyMap(Keys.D7, "7", "&");
            AddKeyMap(Keys.D8, "8", "*");
            AddKeyMap(Keys.D9, "9", "(");

            AddKeyMap(Keys.OemSemicolon, ";", ":");
            AddKeyMap(Keys.OemOpenBrackets, "[", "{");
            AddKeyMap(Keys.OemCloseBrackets, "]", "}");
            AddKeyMap(Keys.OemPeriod, ".", ">");
            AddKeyMap(Keys.Oem5, "\\", "|");
            AddKeyMap(Keys.OemBackslash, "\\", "|");
            AddKeyMap(Keys.Oem7, "'", "\"");
            AddKeyMap(Keys.OemQuestion, "/", "?");
            AddKeyMap(Keys.Oemcomma, ",", "<");
            AddKeyMap(Keys.Oemplus, "=", "+");
            AddKeyMap(Keys.OemMinus, "-", "_");
            AddKeyMap(Keys.Oemtilde, "`", "~");
        }
