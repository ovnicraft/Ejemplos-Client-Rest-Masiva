import sys

import requests

CLIENT_ID = ""
CLIENT_SECRET = ""
GRANT_TYPE = "client_credentials"
ENDPOINT_AUTH = "https://api.login-sms.com/token"
ENDPOINT_SEND_SMS = "https://api.login-sms.com/messages/send"


def get_token():
    auth = requests.post(
        ENDPOINT_AUTH,
        data={
            "client_id": CLIENT_ID,
            "client_secret": CLIENT_SECRET,
            "grant_type": GRANT_TYPE,
        },
    )
    if not auth.ok:
        return False
    return auth.json()


def send_sms(access, number, message):
    headers = {
        "Authorization": f"{access.get('token_type')} {access.get('access_token')}"
    }
    data = {"to_number": number, "content": message}

    res_send = requests.post(ENDPOINT_SEND_SMS, headers=headers, json=data)
    if res_send.ok:
        print("mensaje enviado")
    else:
        print(res_send.text)
        print("mensaje no enviado")


if __name__ == "__main__":
    access = get_token()
    if not access:
        sys.exit(1)
    msg = "Seguros Constitucion informa que su póliza contratada registra un saldo pendiente de 1200.00 con 13 días vencidos. Agradecemos su pago inmediato"
    send_sms(access, "+593995666327", msg)
