# cc_ShadowPlayとは

cc_ShadowPlayはShadowPlayで録画された動画ファイルを切り取り（Clip）したり結合（Combine）したりするツールです。

一つの動画ファイルを任意のタイミングで分割することができます。時間指定はプレビューで動画ファイルを再生しながら確認することができます。変換を行わないため高速に（CPUをほとんど使用せずに）処理することが可能です。

また、動画ファイルを好きな順番に並び替えて任意の個数結合することができますこれも変換を行わないため高速に処理することが可能です。

Twitterやdiscordなどサイズ制限がある動画プラットフォーム向けに解像度を指定してエンコードする機能があります（この場合、エンコード処理を行うためCPUを使用します）。

ShadowPlayの動画を想定していますが他の形式でも大丈夫かもしれません

# 必要なもの
* .NET Framework 4.5
* ffmpeg (実行ファイルのディレクトリ/bin/ffmpeg.exeに配置)

が必要です。

ダウンロードは： https://github.com/nop-jk/cc_ShadowPlay/releases より

## 使い方

### 動画分割
1. 変換前動画ファイル で切り取りたい動画を選択
    * ドラッグ&ドロップでもOK
2. 保存先ディレクトリを指定
3. 保存する動画ファイルのファイル名を指定
4. 切り取り開始時間、終了時間を `時:分:秒` で指定。プレビューを押すことで動画ファイルを再生しながら指定可能
5. 開始を押すと切り取りが開始されます

### 動画結合
1. 追加ボタンで動画ファイルを追加（ドラッグ&ドロップでもOK）
2. 動画を選択して削除ボタンを押すと削除可能
3. ↑↓で並び替え
4. 保存先ディレクトリを指定
5. 保存する動画ファイルのファイル名を指定
6. 開始を押すと結合が開始されます

**注意：結合は同じコーデック、解像度の場合のみ可能**

### その他
実行ファイルのディレクトリに `./finish.wav` という名前で音楽ファイルを置くと終了時に鳴ります。

# Author
JK17sai (@Virtual_JK17sai)

# Thanks
NLC members

# License
GPL: http://www.gnu.org/licenses/gpl.html
ffmpeg: https://ffmpeg.org/

# 履歴
* 2019/10/24 Release v1.1
    * 解像度を指定してエンコードする機能の追加
    * 中止処理の実装
* 2017/05/14 First Release v1.0