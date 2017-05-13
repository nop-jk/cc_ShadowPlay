using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Shell32;

namespace cc_shadowplay {
    public static class Tools {
        private static Shell32.Folder GetShell32NameSpaceFolder(Object folder) {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");

            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace",
            System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }
        public static bool getPositionValue(string movieName, ref int value) {
            FileInfo fileInfo = new FileInfo(movieName);
            Folder folder = GetShell32NameSpaceFolder(fileInfo.DirectoryName);
            FolderItem folderItem = null;
            try {
                folderItem = folder.ParseName(fileInfo.Name);

                if (folderItem != null) {
                    // 時間を取得
                    int index = Environment.OSVersion.Version.Major < 6 ? 21 : 27;

                    string strResultValue = folder.GetDetailsOf(folderItem, index);
                    if (strResultValue.Trim() == "") {
                        string msg = String.Format("{0}: {1}は破損している可能性があります。", DateTime.Now.ToString("F"), movieName);
                        ShowError(msg);
                        return false;
                    }

                    // 時間の変換
                    string[] timeList = strResultValue.Split(':');
                    value = int.Parse(timeList[0]) * 3600;
                    value += int.Parse(timeList[1]) * 60;
                    value += int.Parse(timeList[2]);
                }
            }
            catch (Exception e) {
                string msg = String.Format("{0}: {1}のファイル秒数取得に失敗しました。", DateTime.Now.ToString("F"), movieName);
                ShowError(msg);
                return false;
            }
            finally {
                folder = null;
                fileInfo = null;
                folderItem = null;
            }

            return true;
        }
        public static void ShowError(string errmsg) {
            MessageBox.Show(
                errmsg,
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        public static void PlaySound() {
            if (!File.Exists("finish.wav")) {
                return;
            }
            using (System.Media.SoundPlayer wave = new System.Media.SoundPlayer("finish.wav")) {
                wave.PlaySync();
            }
        }

    }
}
