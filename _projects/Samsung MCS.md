---
name: "MCS"
title: "MCS"
company: "제이원소프트"
layout: page
tools: ["C#", "WPF", ".NET Framework", "PostgreSQL", "MongoDB"]
description: 사업장 내 MES 연동 기반 DRAM 물류 자동화 시스템 개발 및 운영.
---





# MCS(Material Control System) 개발 프로젝트

## 1. 프로젝트 개요
본 프로젝트는 S사의 DRAM 검사 공정에서 발생하는 자재 이송 및 검사 작업을 자동화하기 위해  
Material Control System(MCS)을 개발 및 운영한 프로젝트입니다.
고객사: S사

MCS는 공정 전반의 작업 흐름을 통합적으로 관리하는 상위 제어 시스템으로서,  
Lot 단위의 작업 계획 수립, 설비 상태 판단, 물류 흐름 제어를 담당합니다.  
실제 물리 작업은 하위 제어 시스템인 ACS와 AMR(자율이동로봇)이 수행하며,  
본 시스템은 계획과 실행의 역할을 명확히 분리하여 안정적인 생산 운영을 목표로 설계되었습니다.

![Samsung MCS screenshot 1]({{ "/assets/images/projects/samsung-mcs-1.png" | relative_url }})

---

## 2. 시스템 아키텍처 및 역할 분리

### 전체 구조
- 상위 자동화 시스템  
  - Lot 정보 및 작업 지시 제공
- MCS (본 프로젝트의 핵심 개발 범위)  
  - Lot 및 Step 관리  
  - 작업 스케줄링 및 ExecutionPlan 생성  
  - Area, 설비, 자재 상태에 대한 종합 판단
- ACS (하위 제어 시스템)  
  - ExecutionPlan 해석  
  - 로봇 및 설비 제어
- AMR 및 검사 설비  
  - Cassette, Tray, Memory의 실제 물리 작업 수행

본 구조는 계획(MCS)과 실행(ACS)을 명확히 분리함으로써  
시스템 안정성 및 장애 대응력을 향상시키는 것을 목적으로 합니다.

---

## 3. 물류 및 작업 개념 정리

### 주요 단위 정의
- Lot  
  - 하나의 작업 단위로, 여러 Cassette로 구성되며 동일한 공정 흐름을 따릅니다.
- Cassette  
  - Tray를 담는 물류 단위로, Stocker와 Area 간 이송됩니다.
- Tray  
  - Memory를 적재하는 단위로, Cassette 내부에 배치됩니다.
- Memory  
  - 검사 대상이 되는 시료 단위입니다.

### 설비 구조
- Factory → Area → Table → Set → Slot
- 기본적으로 하나의 Area는 하나의 Lot을 처리하도록 구성됩니다.
- Set은 실제 검사가 수행되는 단위 설비이며,  
  Slot은 Memory가 장착되는 위치를 의미합니다.

![Samsung MCS screenshot 2]({{ "/assets/images/projects/samsung-mcs-2.png" | relative_url }})
![Samsung MCS screenshot 3]({{ "/assets/images/projects/samsung-mcs-3.png" | relative_url }})
---

## 4. ExecutionPlan 기반 제어 구조

MCS는 개별 로봇에 대한 직접 제어를 수행하지 않으며,  
ExecutionPlan 단위로 ACS에 작업을 지시합니다.

### ExecutionPlan
- Area 단위로 생성됩니다.
- 하나의 연속적인 작업 흐름을 의미합니다.
- 여러 Action으로 구성됩니다.
- 하나의 Area에서는 동시에 하나의 Plan만 실행됩니다.

### Action
- AMR 이동을 포함하는 작업 단위입니다.
- 주요 Action 예시는 다음과 같습니다.
  - CassetteLoad / CassetteUnload
  - TrayLoad / TrayUnload
  - MemoryPickAndPlace
  - Start / End

### Job
- Action 수행 위치에 도착한 이후,
- AMR 이동 없이 동일 위치에서 연속적으로 수행되는 로봇 작업의 집합입니다.

본 구조를 통해 작업 연속성과 실행 안정성을 확보하는 동시에,  
하위 제어 시스템의 자율성과 확장성을 유지할 수 있도록 설계되었습니다.

---

## 5. MCS 내부 구조 및 주요 역할

### 주요 기능
- Lot 및 LotStep 생애주기 관리
- Area / Table / Set 상태 관리
- Cassette / Tray / Memory 흐름 제어
- Loading / Unloading Plan 생성
- 작업 진행 상태 추적 및 결과 수집

### 주요 컴포넌트
- FactoryManager  
  - 전체 Area 상태 관리  
  - 자동 Plan 생성 가능 여부 판단
- LotManager  
  - Lot 생성, 진행, 완료 관리
- AreaManager  
  - Area 단위 작업 제어  
  - Loading / Unloading Plan 생성
- CassetteManager  
  - Cassette 이송 및 반납 제어
- PlanManager  
  - ExecutionPlan 관리 및 ACS 전달

---

## 6. Task 기반 실행 방식

MCS는 이벤트 기반 방식이 아닌,  
짧은 주기로 반복 실행되는 Task 구조로 동작합니다.

- TaskLotProcess  
  - Lot 생성, 진행, 완료 처리
- TaskCassetteTransfer  
  - Cassette 이송 및 회수 관리
- TaskAreaWorker  
  - 설비 준비 상태 관리  
  - Loading / Unloading Plan 생성  
  - Set 상태 정리

이와 같은 구조를 통해  
설비 상태 변화 및 물류 흐름을 안정적으로 처리할 수 있도록 구현하였습니다.
