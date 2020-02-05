BEGIN_FUNCTION_MAP
	.Func,EUREX 야간옵션 기간주문체결조회,CEXAQ44200,SERVICE=CEXAQ44200,headtype=B,CREATOR=,CREDATE=2012/11/08 17:10:28;
	BEGIN_DATA_MAP
	CEXAQ44200InBlock1,In(*EMPTY*),input;
	begin
		레코드갯수, RecCnt, RecCnt, long, 5
		선택입력구분, ChoicInptTpCode, ChoicInptTpCode, char, 1;
		계좌번호, AcntNo, AcntNo, char, 20;
		비밀번호, Pwd, Pwd, char, 8;
		조회시작일, QrySrtDt, QrySrtDt, char, 8;
		조회종료일, QryEndDt, QryEndDt, char, 8;
		체결구분, PrdtExecTpCode, PrdtExecTpCode, char, 1;
		선물옵션거래유형코드, FnoTrdPtnCode, FnoTrdPtnCode, char, 2;
		시작주문번호2, SrtOrdNo2, SrtOrdNo2, long, 10;
		정렬순서구분, StnlnSeqTp, StnlnSeqTp, char, 1;
	end
	CEXAQ44200OutBlock1,In(*EMPTY*),output;
	begin
		레코드갯수, RecCnt, RecCnt, long, 5
		선택입력구분, ChoicInptTpCode, ChoicInptTpCode, char, 1;
		계좌번호, AcntNo, AcntNo, char, 20;
		비밀번호, Pwd, Pwd, char, 8;
		조회시작일, QrySrtDt, QrySrtDt, char, 8;
		조회종료일, QryEndDt, QryEndDt, char, 8;
		체결구분, PrdtExecTpCode, PrdtExecTpCode, char, 1;
		선물옵션거래유형코드, FnoTrdPtnCode, FnoTrdPtnCode, char, 2;
		시작주문번호2, SrtOrdNo2, SrtOrdNo2, long, 10;
		정렬순서구분, StnlnSeqTp, StnlnSeqTp, char, 1;
	end
	CEXAQ44200OutBlock2,Out(*EMPTY*),output;
	begin
		레코드갯수, RecCnt, RecCnt, long, 5
		주문수량, OrdQty, OrdQty, long, 16;
		체결수량, ExecQty, ExecQty, long, 16;
		미체결수량, UnercQty, UnercQty, long, 16;
		체결가, ExecPrc, ExecPrc, double, 15.2;
	end
	CEXAQ44200OutBlock3,Out1(*EMPTY*),output,occurs;
	begin
		계좌번호1, AcntNo1, AcntNo1, char, 20;
		계좌명, AcntNm, AcntNm, char, 40;
		주문일, OrdDt, OrdDt, char, 8;
		주문번호, OrdNo, OrdNo, long, 10;
		원주문번호, OrgOrdNo, OrgOrdNo, long, 10;
		주문시각, OrdTime, OrdTime, char, 9;
		종목번호, IsuNo, IsuNo, char, 12;
		종목명, IsuNm, IsuNm, char, 40;
		매매구분, BnsTpNm, BnsTpNm, char, 10;
		매매구분, BnsTpCode, BnsTpCode, char, 1;
		유렉스호가구분코드, ErxOrdprcTpCode, ErxOrdprcTpCode, char, 1;
		정정취소구분명, MrcTpNm, MrcTpNm, char, 10;
		유렉스가격조건구분코드, ErxPrcCndiTpCode, ErxPrcCndiTpCode, char, 1;
		코드명, CodeNm, CodeNm, char, 40;
		주문가, OrdPrc, OrdPrc, double, 13.2;
		주문수량, OrdQty, OrdQty, long, 16;
		선물옵션거부사유코드, FnoRjtRsnCode, FnoRjtRsnCode, char, 3;
		주문구분명, OrdTpNm, OrdTpNm, char, 10;
		체결구분명, ExecTpNm, ExecTpNm, char, 10;
		체결가, ExecPrc, ExecPrc, double, 13.2;
		체결수량, ExecQty, ExecQty, long, 16;
		체결시각, ExecTime, ExecTime, char, 9;
		체결번호, ExecNo, ExecNo, long, 10;
		미체결수량, UnercQty, UnercQty, long, 16;
		사용자ID, UserId, UserId, char, 16;
		통신매체코드, CommdaCode, CommdaCode, char, 2;
		통신매체코드명, CommdaCodeNm, CommdaCodeNm, char, 40;
		IP주소, IpAddr, IpAddr, char, 16;
		거래유형구분, TrdPtnTpNm, TrdPtnTpNm, char, 20;
		유렉스주문상태코드, ErxOrdStatCode, ErxOrdStatCode, char, 1;
		코드명0, CodeNm0, CodeNm0, char, 40;
		거래소접수시각, ExchRcptTime, ExchRcptTime, char, 30;
	end
	END_DATA_MAP
END_FUNCTION_MAP
