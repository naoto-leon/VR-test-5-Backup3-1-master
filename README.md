# VR-test-4-Backup2-2
VR Oculus-Go Beatsaver 

#### Oculus GoでBeatSaverを作りました。初めてのVR開発でわりかし手間取ったのと時間を掛けたので詳細に記録します。
##### [YouTube](https://youtu.be/9nsiCdtRgEo)
![VR_GIF1](https://user-images.githubusercontent.com/43961147/61991270-e2493480-b088-11e9-8c0b-e08919d54cd5.gif)

***

### 製作動機　

恐らくBeat-Saverをやる為にVRの購入をした人は多いと思う、僕もその一人です。　
しかし、当時の僕はVRに関して全くの無知であり、適正機種がある事など全く知らなかったので、取り敢えず安いお手頃のOculas-Goを買いました。　
##### が、しかし、ご存知の通りOculas-GoではBeat-Saverが出来ない。　　
なんとも悔しい気持ちになったので作ってみました。
結果や満足度に関しては最後にまとめてあります。

***
### 開発環境　

#### Oculas-Go 
□ 3Dof（回転のみ)  
□ 60~72hz 

#### MacBook Pro 
□  グラフィック   
　Radeon Pro 450 2 GB  
　Intel HD Graphics 530 1536 MB  
□  バージョン　10.14.5  

#### Unity 
□  バージョン　2019 1.8f1  
□  レンダリング　LWRP  

#### Andoroid SDK 
□ Andoroid 9.0(pie) 

#### JDK 
□ java version "1.8.0_211"  

大事なのはUnityとOculas-Goのスペックと設定。  
まず、3DofというのはVR空間において首の動きのみ連動するという事。（対して屈んだりの動作にも連動している機種を6Dofという）  
正規のBeat-Saverは6Dof対応。  
また、60~72hzはリフレッシュノートであるが、PsVRなどの機種が120hzに対してかなり低い。  
どれくらい低いかというと、スマホと同じくらい。  
なお、スタンドアローン型？(Pcとの連動で動くやつじゃないやつ)。
#### 自分なりにまとめると、スマホのスペックでVRの挙動を実装しなくてはいけない。  
これがかなりネック  
Pc開発時でのFpsが150オーバーにも関わらず実機で確認すると挙動がガタツク場合がある。  

