---
layout: page
title: About
permalink: /about/
weight: 3
---

# **About Me**

Hi I am **{{ site.author.name }}** :wave:,<br>
I build software and enjoy turning ideas into products with clean, maintainable code.

**Quick Links**
- [Home]({{ site.baseurl }}/)
- [Projects]({{ site.baseurl }}/projects/)
- [GitHub](https://github.com/seokhoyoun)

## Education
- 한국방송통신대학교(4년제), 컴퓨터과학과 (2019.03 ~ 재학중)
- 대입 검정고시(고졸), 2011.01 (검정고시 합격)

<div class="row">
{% include about/skills.html title="Programming Skills" source=site.data.programming-skills %}
{% include about/skills.html title="Other Skills" source=site.data.other-skills %}
</div>

<div class="row">
{% include about/timeline.html %}
</div>
