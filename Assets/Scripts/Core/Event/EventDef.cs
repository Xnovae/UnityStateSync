using System;


public enum EventDef
{
    NetConnectSuccess,  //�������ӳɹ�
    NetConnectFaild,    //��������ʧ��
    NetDisconnect,      //����Ͽ�����
    NetReconnect,       //��������
    NetRecvOrSendDisconnect,

    RoleLoginOk,        //��ɫ��½�ɹ�

    PlaySingelResetState,


    PlayRunLastOver,    //�ϴ��������
    PlayRunColorOver,   //��ɫת�����
    PlayRunP2POver,     //�㵽��ת�����
    PlayRunP2POneOver,  //�㵽��ת�����(ֻ��βһ����)
    PlayAudioFruitOver, //ˮ�������������
    PlayAudioFruitOver2,//ˮ�������������
    PlayAudioColorOver, //��ɫ�����������
    PlayAudioDongOver,  //����dong�������
    PlayAudioDongOver2,  //����dong�������
    PlayAudioDongOver3,  //����dong�������
    PlayAudioDongOver4,  //����dong�������
    PlayAudioSongOver,
    PlayAudioCJOver,
    PlayAudioCongratulations,
    PlayAudioCongratulations2,
    PlayAudioDingDingOver,
    PlayAudioJiuJiuBangOver,
    PlayAudioChanceComeOver,
    PlayAudioBababaOver,
    PlayAudioTLBBOver,
    PlayAudioXMBSOver,
    PlayAudioOneMoreOver,
    PlayAudioSwikeOver,
    PlayAudioZhaOver,
    PlayAudioTimesOver,
    PlayAudioZhuDongDongOver,
    PlayAudioAouOver,
    PlayAudioYJSDOver,
    PlayAudioYeDuDuOver,
    PlayAudioZHSHOver,
    PlayAudioShutUpOver,
    PlayAudioJiuJiuHalfOver,
    PlayAudioJGNDXSOver,
    PlayAudioDuoShiYaOver,
    PlayAudioDengDengOver,
    PlayAudioJiuJiuOver,

    PlayRunTurn4DirOver,  //4������ת��

    PlayAudioSYDengDengOver,
    PlayAudioSYThreeYuanOver,
    PlayRunThreeYuanOver,

    PlayDDPRunAllFruitHighOver,
    PlayDDPAudioOver,
    PlayDDPAudioDengDengOver,
    PlayDDPRunDDPOver,

    PlayDMGAudioBBBOver,
    PlayDMGAudioOver,
    PlayDMGRunOver,

    PlayJLBDAudioOver,
    PlayJLBDAudioDengDengOver,
    PlayJLBDRunOver,

    PlayCjBBBAudioJiuJiuBangOver,
    PlayCjBBBAudioCjbbbOver,
    PlayCjBBBAudioJiuJiuDuOver,
    PlayCjBBBAudioTimesOver,
    PlayCjBBBRunMulOver,

    PlayFHLAudioOver,

    PlayZHSHTurnOver,
    PlayDARENTurnOver,

    PlayBarRunJiuJiuJiuThreeOver,

    RoomBack,
    RoomBackOk,

    ChatType,
    RmbMultiClick,

    LoginUnameOk,
}
