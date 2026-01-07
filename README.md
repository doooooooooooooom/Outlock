# Outlock

**Outlock** is a background security utility that automatically **terminates Microsoft Outlook** whenever someone attempts to open it.

The program continuously monitors running processes and immediately kills the Outlook application to prevent access.

---

## 🔒 Purpose

Outlock is designed for environments where:
- Outlook access must be **strictly blocked**
- No password prompt or user interaction is desired
- Outlook should never remain running, even briefly

Typical use cases:
- Public or shared computers
- Kiosk systems
- Restricted office environments
- Temporary lockdown scenarios

---

## ⚙️ How It Works

- Runs as a **background process**
- Monitors system processes
- Detects `OUTLOOK.EXE`
- Instantly terminates the process

There is **no UI**, **no password**, and **no warning** — Outlook is simply closed as soon as it starts.

---

## 🚀 Features

- Lightweight and fast
- No configuration required
- Automatically restarts monitoring
- Works silently in the background
- Prevents Outlook from staying open

---

## 🖥 Requirements

- Windows OS
- Microsoft Outlook installed
- Sufficient permissions to terminate processes

---

## 📌 Notes

- This program does **not** uninstall Outlook
- This program does **not** modify system files
- Outlook can only run again after **Outlock is stopped**

---

## ⚠️ Disclaimer

Use this tool responsibly.  
Killing system or user applications without notice may result in data loss if Outlook is in use.

---

## 📄 License

Specify your license here (MIT, Apache 2.0, proprietary, etc.)
